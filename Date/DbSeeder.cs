using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Date
{
    public class DbSeeder
    {
        private readonly AppDbContext _dbContext;
        private readonly Random _random = new Random();

        private readonly string[] _projectStatuses = { "Новый", "В работе", "Закончен" };
        private readonly string[] _profileTypes = { "Сейсмический", "Гравиметрический", "Магнитный", "Электрический" };
        private readonly string[] _measurementTypes = { "Тип A", "Тип B", "Тип C", "Тип D" };
        private readonly string[] _electrodeTypes = { "Тип A", "Тип B", "Тип C", "Тип D" };

        public DbSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {

            // Добавляем проекты
            var projects = Enumerable.Range(1, 5)
                .Select(i => new Models.Project
                {
                    CustomerID = _random.Next(1, 4),
                    ProjectName = $"Проект {i}",
                    Status = _projectStatuses[_random.Next(_projectStatuses.Length)]
                }).ToList();

            _dbContext.Projects.AddRange(projects);
            _dbContext.SaveChanges();

            // Добавляем площади для каждого проекта
            foreach (var project in projects)
            {
                var areas = Enumerable.Range(1, 5)
                    .Select(j => new Area
                    {
                        AreaDescription = $"Площадь {j} проекта {project.ProjectName}",
                        AreaCoordinates = GenerateRandomPolygon(
                            minPoints: 4,
                            maxPoints: 8,  // До 8 углов у полигона
                            minX: 50,
                            maxX: 500,
                            minY: 60,
                            maxY: 500)
                    }).ToList();

                _dbContext.Areas.AddRange(areas);
                _dbContext.SaveChanges();

                // Связываем площади с проектом
                var projectAreas = areas.Select(a => new ProjectArea
                {
                    ProjectID = project.ProjectID,
                    AreaID = a.AreaID
                }).ToList();

                _dbContext.ProjectAreas.AddRange(projectAreas);

                // Добавляем профили для каждой площади
                foreach (var area in areas)
                {
                    var profiles = Enumerable.Range(1, 3) // 3 профиля на площадь
                        .Select(k => new Profile
                        {
                            ProfileType = _profileTypes[_random.Next(_profileTypes.Length)],
                            ProfileCoordinates = GenerateProfileInsideArea(area.AreaCoordinates.ToList())
                        }).ToList();

                    _dbContext.Profiles.AddRange(profiles);
                    _dbContext.SaveChanges();

                    // Связываем профили с площадью
                    var areaProfiles = profiles.Select(p => new AreaProfile
                    {
                        AreaID = area.AreaID,
                        ProfileID = p.ProfileID
                    }).ToList();

                    _dbContext.AreaProfiles.AddRange(areaProfiles);

                    // Добавляем пикеты для каждого профиля
                    foreach (var profile in profiles)
                    {
                        var pickets = Enumerable.Range(1, 20)
                            .Select(m => new Picket
                            {
                                Latitude = 55.0 + _random.NextDouble() * 0.1,
                                Longitude = 37.0 + _random.NextDouble() * 0.1,
                                Measurements = new[]
                                {
                                    new Measurement
                                    {
                                        MeasurementDate = DateTime.Now.AddDays(-_random.Next(365)),
                                        MeasurementType = _measurementTypes[_random.Next(_measurementTypes.Length)],
                                        ElectrodeType = _electrodeTypes[_random.Next(_electrodeTypes.Length)],
                                        Value = Math.Round(10 + _random.NextDouble() * 90, 2), // Значения от 10.00 до 100.00
                                        Unit = "Ом·м"
                                    }
                                }
                            }).ToList();

                        _dbContext.Pickets.AddRange(pickets);
                        _dbContext.SaveChanges();

                        // Связываем пикеты с профилем
                        var profilePickets = pickets.Select(p => new ProfilePicket
                        {
                            ProfileID = profile.ProfileID,
                            PicketID = p.PicketID
                        }).ToList();

                        _dbContext.ProfilePickets.AddRange(profilePickets);
                    }
                }
            }

            _dbContext.SaveChanges();
        }

        public void ClearDatabase()
        {
            // Очищаем все таблицы в правильном порядке (чтобы избежать проблем с внешними ключами)
            _dbContext.Measurements.RemoveRange(_dbContext.Measurements);
            _dbContext.ProfilePickets.RemoveRange(_dbContext.ProfilePickets);
            _dbContext.Pickets.RemoveRange(_dbContext.Pickets);
            _dbContext.AreaProfiles.RemoveRange(_dbContext.AreaProfiles);
            _dbContext.Profiles.RemoveRange(_dbContext.Profiles);
            _dbContext.ProfileCoordinates.RemoveRange(_dbContext.ProfileCoordinates);
            _dbContext.ProjectAreas.RemoveRange(_dbContext.ProjectAreas);
            _dbContext.Areas.RemoveRange(_dbContext.Areas);
            _dbContext.AreaCoordinates.RemoveRange(_dbContext.AreaCoordinates);
            _dbContext.Projects.RemoveRange(_dbContext.Projects);

            _dbContext.SaveChanges();
        }

        // Метод для генерации случайного полигона (минимум 4 точки)
        private List<AreaCoordinate> GenerateRandomPolygon(int minPoints, int maxPoints, int minX, int maxX, int minY, int maxY)
        {
            var pointsCount = _random.Next(minPoints, maxPoints + 1);
            var centerX = _random.Next(minX, maxX);
            var centerY = _random.Next(minY, maxY);
            var radiusX = _random.Next(50, 200);
            var radiusY = _random.Next(50, 200);

            var coordinates = new List<AreaCoordinate>();

            // Генерируем точки по "неровному кругу"
            for (int i = 0; i < pointsCount; i++)
            {
                double angle = 2 * Math.PI * i / pointsCount;

                // Добавляем случайные отклонения для "рваного" края
                double irregularity = 0.3 + _random.NextDouble() * 0.7;
                double x = centerX + radiusX * Math.Cos(angle) * irregularity;
                double y = centerY + radiusY * Math.Sin(angle) * irregularity;

                // Добавляем небольшие случайные смещения
                x += _random.Next(-20, 20);
                y += _random.Next(-20, 20);

                coordinates.Add(new AreaCoordinate { X = x, Y = y });
            }

            return coordinates;
        }
        private List<ProfileCoordinate> GenerateProfileInsideArea(List<AreaCoordinate> areaCoordinates)
        {
            var profileCoords = new List<ProfileCoordinate>();

            // Находим границы площади
            double minX = areaCoordinates.Min(c => c.X);
            double maxX = areaCoordinates.Max(c => c.X);
            double minY = areaCoordinates.Min(c => c.Y);
            double maxY = areaCoordinates.Max(c => c.Y);

            // Генерируем случайную линию профиля внутри bounding box
            double x1 = minX + (maxX - minX) * _random.NextDouble();
            double y1 = minY + (maxY - minY) * _random.NextDouble();
            double x2 = minX + (maxX - minX) * _random.NextDouble();
            double y2 = minY + (maxY - minY) * _random.NextDouble();

            // Создаем 5 точек вдоль линии профиля
            for (int i = 0; i < 5; i++)
            {
                double t = i / 4.0;
                double x = x1 + t * (x2 - x1);
                double y = y1 + t * (y2 - y1);

                // Добавляем небольшие случайные отклонения
                x += (maxX - minX) * (_random.NextDouble() - 0.5) * 0.1;
                y += (maxY - minY) * (_random.NextDouble() - 0.5) * 0.1;

                profileCoords.Add(new ProfileCoordinate { X = x, Y = y });
            }

            return profileCoords;
        }
    }
}

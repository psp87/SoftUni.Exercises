namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Newtonsoft.Json;

    using Cinema.Data.Models;
    using Cinema.DataProcessor.ImportDto;
    using Data;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";
        private const string SuccessfulImportMovie 
            = "Successfully imported {0} with genre {1} and rating {2}!";
        private const string SuccessfulImportHallSeat 
            = "Successfully imported {0}({1}) with {2} seats!";
        private const string SuccessfulImportProjection 
            = "Successfully imported projection {0} on {1}!";
        private const string SuccessfulImportCustomerTicket 
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var moviesDtos = JsonConvert.DeserializeObject<MovieImportDto[]>(jsonString);

            var movies = new List<Movie>();

            foreach (var dto in moviesDtos)
            {
                if (IsValid(dto))
                {
                    var movie = new Movie()
                    {
                        Title = dto.Title,
                        Genre = dto.Genre,
                        Duration = dto.Duration,
                        Rating = dto.Rating,
                        Director = dto.Director
                    };

                    movies.Add(movie);

                    sb.AppendLine(String.Format(SuccessfulImportMovie, dto.Title, dto.Genre, dto.Rating.ToString("F2")));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Movies.AddRange(movies);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportHallSeats(CinemaContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var dtos = JsonConvert.DeserializeObject<HallSeatsImportDto[]>(jsonString);

            foreach (var dto in dtos)
            {
                if (IsValid(dto))
                {
                    var hall = new Hall()
                    {
                        Name = dto.Name,
                        Is4Dx = dto.Is4Dx,
                        Is3D = dto.Is3D,
                    };

                    context.Halls.Add(hall);
                    AddSeatInDatabase(context, hall.Id, dto.Seats);

                    string projectionType = GetProjectionType(hall);

                    sb.AppendLine(String.Format(SuccessfulImportHallSeat, dto.Name, projectionType, dto.Seats));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object obj)
        {
            var result = Validator.TryValidateObject(obj, new ValidationContext(obj), new List<ValidationResult>(), true);
            return result;
        }

        private static string GetProjectionType(Hall hall)
        {
            if (hall.Is3D && hall.Is4Dx)
            {
                return "4Dx/3D";
            }
            else if (hall.Is3D)
            {
                return "3D";
            }
            else if (hall.Is4Dx)
            {
                return "4Dx";
            }
            else
            {
                return "Normal";
            }
        }

        private static void AddSeatInDatabase(CinemaContext context, int hallId, int seatsCount)
        {
            var seats = new List<Seat>();

            for (int i = 0; i < seatsCount; i++)
            {
                seats.Add(new Seat { HallId = hallId });
            }

            context.Seats.AddRange(seats);
            context.SaveChanges();
        }
    }
}
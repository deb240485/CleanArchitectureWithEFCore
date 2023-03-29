using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<bool> CreateMovie(Movie movie)
        {
            return await _movieRepository.CreateMovie(movie);
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await _movieRepository.GetAllMovies();
        }
    }
}

import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../movies.service';
import { Movies } from './model/movieModel';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css'],
})
export class MovieComponent implements OnInit {
  constructor(private movieService: MoviesService) {}
  movies: Movies[];
  ngOnInit(): void {
    this.movieService.getMovies();
  }
}

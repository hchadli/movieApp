import { Injectable } from '@angular/core';
import { Movies } from './movie/model/movieModel';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MoviesService {
  constructor(private _http: HttpClient) {}

  private fakeData: Movies[] = [
    {
      id: 5,
      title: 'boubouLand',
      genre: 'action',
      description: 'lorem iprumm',
      releaseDate: '2014-02-02',
      actors: [
        {
          name: 'boubou',
          fullName: 'okokok',
        },
      ],
    },
    {
      id: 94,
      title: 'boubi',
      genre: 'horror',
      description: 'lorem iprumm',
      releaseDate: '2014-02-02',
      actors: [
        {
          name: 'boubou',
          fullName: 'okokok',
        },
      ],
    },
  ];

  getMovies() {
    return console.log(this.fakeData);
  }
}

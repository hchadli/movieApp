import { Actor } from './actorsModel';
export interface Movies {
  id: number;
  title: string;
  genre: string;
  description: string;
  releaseDate: string;
  actors: Actor[];
}

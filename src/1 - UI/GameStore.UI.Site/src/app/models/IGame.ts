import { IPlataform } from '../models/IPlataform';
import { IGenre } from '../models/IGenre';
import { IDeveloper } from '../models/IDeveloper';
import { IPublisher } from '../models/IPublisher';

export interface IGame {
    name: string;
    releaseDate: string;
    rating: number;
    score: number;
    description: string;
    shortDescription: string;
    imageUrl: string;
    gamePlataforms: IPlataform;
    gameGenres: IGenre;
    gameDevelopers: IDeveloper;
    gamePublishers: IPublisher;
}

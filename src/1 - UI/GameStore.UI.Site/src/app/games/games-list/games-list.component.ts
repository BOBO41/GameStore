import { Component, OnInit } from '@angular/core';
import { GameServices } from './games-services';

import { IGame } from '../../models/IGame';

@Component({
  selector: 'app-games-list',
  templateUrl: './games-list.component.html',
  styleUrls: ['./games-list.component.css'],
  providers: [GameServices]
})
export class GamesListComponent implements OnInit {

  games: IGame[];
  teste: string;

  constructor(private _gameServices: GameServices) { }

  ngOnInit() {
    this._gameServices.getProducts()
      .subscribe( games => this.games = games);
  }
}

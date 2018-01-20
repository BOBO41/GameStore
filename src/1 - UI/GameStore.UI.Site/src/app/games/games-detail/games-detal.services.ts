import { Component, OnInit, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

import { IGame } from '../../models/IGame';

@Injectable()
export class GameDetailServices implements OnInit {

    id: string;

    private gamesDetailUrl = 'http://localhost/gamestore/api/games/' + this.id;

    constructor(private _http: HttpClient) { }

    ngOnInit() {
        this.id = 
    }

    getProducts(): Observable<IGame[]> {
        return this._http.get<IGame[]>(this.gamesDetailUrl);
    }
}

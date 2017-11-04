import { Component, OnInit, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

import { IGame } from '../../models/IGame';

@Injectable()
export class GameServices implements OnInit {

    private gamesUrl = 'http://localhost/gamestore/api/games';

    constructor(private _http: HttpClient) { }

    ngOnInit() { }

    getProducts(): Observable<IGame[]> {
        return this._http.get<IGame[]>(this.gamesUrl);
    }
}

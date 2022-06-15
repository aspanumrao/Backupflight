import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { UserFlightSearch } from './Models/UserFlightSearch';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private booksuserdata = new BehaviorSubject<UserFlightSearch>(new UserFlightSearch());
  book = this.booksuserdata.asObservable()
  constructor() { }
  changeName(book:any) {
    this.booksuserdata.next(book);
  }
}

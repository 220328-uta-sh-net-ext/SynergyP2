import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError, catchError, pipe } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  token: string = "";
  login(Username: string, Password: string, Email: string): Observable<any> {
    return this.http.post("http://growthapi.azurewebsites.net/UserLoginAPI/Authenticate/User", JSON.stringify({ Username, Password, Email }),

      {
        headers: { 'Content-Type': 'application/json' },
  }
     )
      .pipe(
        catchError((e) => {
          return throwError(e);
        }))

}
  constructor(private http: HttpClient) {}
}

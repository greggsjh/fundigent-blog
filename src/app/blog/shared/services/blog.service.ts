import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { BlogResponse } from "../blogresponse.model";

@Injectable({
  providedIn: "root",
})
export class BlogService {
  private postsUrl = environment.backendUrl + "/api/posts";
  constructor(private http: HttpClient) {}

  list(): Observable<BlogResponse> {
    return this.http.get<BlogResponse>(this.postsUrl);
  }
}

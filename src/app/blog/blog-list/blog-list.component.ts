import { Component, OnInit, Input } from "@angular/core";
import { Blog } from "../shared/blog.model";

@Component({
  selector: "app-blog-list",
  templateUrl: "./blog-list.component.html",
  styleUrls: ["./blog-list.component.css"],
})
export class BlogListComponent implements OnInit {
  @Input()
  posts: Blog[] = [];
  constructor() {}

  ngOnInit() {
    console.log("From BlogListComponent: " + this.posts);
  }
}

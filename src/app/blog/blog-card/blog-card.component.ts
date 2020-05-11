import { Component, OnInit, Input } from "@angular/core";
import { Blog } from "../shared/blog.model";

@Component({
  selector: "app-blog-card",
  templateUrl: "./blog-card.component.html",
  styleUrls: ["./blog-card.component.css"],
})
export class BlogCardComponent implements OnInit {
  @Input()
  post: Blog;
  constructor() {}

  ngOnInit() {
    console.log("From BlogCardComponent: " + this.post);
  }
}

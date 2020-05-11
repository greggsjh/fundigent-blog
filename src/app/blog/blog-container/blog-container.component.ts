import { Component, OnInit, Output } from "@angular/core";
import { BlogService } from "../shared/services/blog.service";
import { Blog } from "../shared/blog.model";
import { BlogResponse } from "../shared/blogresponse.model";

@Component({
  selector: "app-blog-container",
  templateUrl: "./blog-container.component.html",
  styleUrls: ["./blog-container.component.css"],
})
export class BlogContainerComponent implements OnInit {
  posts: Blog[];
  constructor(private blogService: BlogService) {}

  ngOnInit() {
    this.blogService.list().subscribe((data: BlogResponse) => {
      this.posts = Object.assign(new Array<Blog>(), data.posts);
    });
  }
}

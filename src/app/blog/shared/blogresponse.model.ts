import { Blog } from "./blog.model";
import { Link } from "./link.model";

export class BlogResponse {
  /**
   *
   */
  constructor(public posts: Blog[], public links: Link[]) {}
}

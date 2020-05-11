import { BlogResponse } from "./blogresponse.model";
import { Blog } from "./blog.model";
import { Link } from "./link.model";

describe("Response", () => {
  it("should create an instance", () => {
    expect(new BlogResponse(new Array<Blog>(), new Array<Link>())).toBeTruthy();
  });
});

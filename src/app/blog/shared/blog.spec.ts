import { Blog } from "./blog.model";
import { User } from "./user.model";

describe("Blog", () => {
  it("should create an instance", () => {
    expect(
      new Blog(
        "16e9c70e-14bd-411c-ab9a-fba51f2f4610",
        "Rest and Web APIs",
        "",
        "APIs",
        Array<Comment>(0),
        new Date(),
        new Date()
      )
    ).toBeTruthy();
  });
});

import { Comment } from "./comment.model";
import { User } from "./user.model";

describe("Comment", () => {
  it("should create an instance", () => {
    expect(
      new Comment(
        "",
        "test text",
        new User(
          "35a1eba1-35dc-41e7-945b-8eca647f20ba",
          "jtester",
          "P@ssword1",
          "Johnny",
          null,
          "Test",
          "Here's Johnny!",
          "johnnyt@test.com"
        ),
        new Date()
      )
    ).toBeTruthy();
  });
});

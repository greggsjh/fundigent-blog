import { User } from "./user.model";

describe("User", () => {
  it("should create an instance", () => {
    expect(
      new User(
        "83e657b6-a4c2-4dc0-bff1-0059bf96334e",
        "greggsjh",
        "password",
        "Jamison",
        null,
        "Greggs",
        "JayGregg100",
        "jamisonhgreggs@gmail.com"
      )
    ).toBeTruthy();
  });
});

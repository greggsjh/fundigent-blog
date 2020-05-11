import { User } from "./user.model";

export class Comment {
  /**
   *
   */
  constructor(
    public id: string,
    public text: string,
    public user: User,
    public createdDate: Date
  ) {}
}

import { Link } from "./link.model";

export class Blog {
  /**
   *
   */
  constructor(
    public id: string,
    public title: string,
    public text: string,
    public blogCategory: string,
    public comments: Comment[],
    public createdDate: Date,
    public modifiedDate: Date,
    public links: Link[]
  ) {}
}

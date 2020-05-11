export class User {
  /**
   *
   */
  constructor(
    public id: string,
    public username: string,
    public password: string,
    public firstname: string,
    public middlename: string,
    public lastname: string,
    public displayname: string,
    public email: string
  ) {}
}

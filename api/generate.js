module.exports = function() {
  var faker = require("faker");
  var _ = require("lodash");

  return {
    posts: _.times(100, function(n) {
      return {
        id: n,
        title: faker.lorem.words(3),
        text: faker.lorem.paragraphs(3),
        comments: _.times(3, function(x) {
          var fn = faker.name.firstName();
          var ln = faker.name.lastName();
          var mn = faker.name.firstName();
          return {
            id: x,
            text: faker.lorem.sentence(1, 4),
            user: {
              id: faker.random.number(100),
              firstname: fn,
              middlename: mn,
              lastname: ln,
              username: faker.internet.userName(fn, ln),
              email: faker.internet.email(fn, ln)
            }
          };
        }),
        user: {
          id: 21075,
          firstName: "Jamison",
          middlename: "",
          lastName: "Greggs",
          username: "jaygregg100",
          email: "jaygregg100@gmail.com"
        }
      };
    })
  };
};

using System;
using System.Collections.Generic;
using Fundigent.Blog.CoreObjects.Entities;
using Fundigent.Blog.CoreObjects.Enums;
using Microsoft.EntityFrameworkCore;

namespace Fundigent.Blog.Data
{
    public class FundigentDbContext : DbContext
    {
        public FundigentDbContext(DbContextOptions<FundigentDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = new Guid("83e657b6-a4c2-4dc0-bff1-0059bf96334e"),
                  FirstName = "Jay",
                  LastName = "Gee",
                  UserName = "jhg",
                  Password = "P@ssword1",
                  DisplayName = "BlueJay",
                  Email = "jay999@gmail.com",
                  BlogRole = (int)BlogRole.BlogAdmin
              },
              new User
              {
                  Id = new Guid("35a1eba1-35dc-41e7-945b-8eca647f20ba"),
                  FirstName = "Johnny",
                  LastName = "Test",
                  UserName = "jtester",
                  Password = "P@ssword1",
                  DisplayName = "Here's Johnny!",
                  Email = "johnnyt@test.com",
                  BlogRole = (int)BlogRole.BlogReader
              },
              new User
              {
                  Id = new Guid("183fbe51-5258-49b4-9231-55829c18d8c9"),
                  FirstName = "Jane",
                  LastName = "Tester",
                  UserName = "janetester",
                  Password = "P@ssword1",
                  DisplayName = "Jane",
                  Email = "jane.tester@test.com",
                  BlogRole = (int)BlogRole.BlogReader
              }
            );

            modelBuilder.Entity<Post>().HasData(
              new Post
              {
                  Id = new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"),
                  Title = "Rest and Web APIs",
                  Text = @"<p>Before we get into more specific details of what makes a web API RESTful, we should probably cover a
                      bit of history. Distributed computing is defined as the communication of one computing system with
                      another computing system where these systems are separated geographically and/or physically using
                      some network. Distributed computing has a long history, going back to the early days of computing and
                      networks. One of the most common ways that we utilize distributed systems today is with HTTP and the internet.</p>

                      <p>But what is REST? Well Representational State Transfer (REST) is an architectural principle or style that
                      says the transfer or modification of data or the state of data should represent the underlying resources
                      of the system providing that data. Additionally, the operations used to modify or transfer that data
                      should be pre-defined and stateless. So, for a web API, the resources that are represented are web
                      resources that map to contextual entities within our system. These contextual entities do not necessarily
                      map to the internal entities in our system, but can be any abstraction that can be named, addressed, or
                      otherwise identified. Also, because this is a Web API, we are using the HTTP protocol. Hyper-Text
                      Transfer Protocol (HTTP) is inherently stateless, so we have that covered and because HTTP also defines
                      a set of methods or verbs, we can use these to satisfy REST’s pre-defined operations requirement.</p>

                      <p>How is REST different from SOAP? Both REST and SOAP solve many of the same problems. It is deeper
                      than JSON vs XML (which can be supported using REST by the way). However, SOAP requires the use of
                      an arbitrary set of self-described operations. It can be argued, that REST provides a cleaner structure for
                      solving the same problems more easily.</p>

                      <p>In my next post, I will get into more of the details of how HTTP enables the creation of RESTful web APIs
                      and some considerations the proper design of your web API.</p> ",
                  BlogCategory = (int)BlogCategory.APIs,
                  CreatedDate = DateTime.Now,
                  ModifiedDate = DateTime.Now
              }
            );

            modelBuilder.Entity<Post>().HasData(
              new Post
              {
                  Id = new Guid("c2e1b06c-42c8-4a6e-ae9b-cd1e12769b09"),
                  Title = "Data Structures Overview",
                  Text = @"What is a data structure?
                  <ul>
                    <li>Data structure – classes that are used to organize data and provide various operations on that data; organize and operate on data.</li>
                  </ul>
                  How is the efficiency of data structures analyzed?
                  <ul>
                   	<li>Asymptotic analysis (Big-Oh) – a method of analysis that measures how the efficiency of a data structure changes as the data structure’s size approaches infinity.</li>
                    <li>Asymptotic analysis steps</li>
                    <ol>
                      <li>Determine the steps that constitute the algorithm’s running time. Typically, one should concern him or herself with steps that involve the data structure itself, NOT simple atomic operations performed by the computer.</li>
                      <li>Find the lines of code that perform the steps of interest in counting and put a ‘1’ next to each of these lines.</li>
                      <li>For each line with a ‘1’ next to it, see if said line is in a loop. If so, change the ‘1’ to ‘1’ times the maximum number of repetitions the loop may perform. If there are 2 or more nested loops, continue the multiplication for each loop.</li>
                      <li>Find the largest single term written above; this is the running time.</li>
                    </ol>
                  </ul>
                  Why is the analysis of efficiency important?
                  <ul>
                    <li>The analysis of efficiency is important when choosing the data structure and algorithm to use when solving a problem in the real-world. It is not a definitive method of choosing an algorithm, but can be used as part of the process. One algorithm may outperform another when working on sufficiently sized data depending further upon the specific implementation.</li>
                  </ul>
                  Types of data structures:
                  <ul>
                    <li>Array – contains a homogeneous, contiguous collection of data items that can be accessed by an ordinal index; one of the most common data structures.</li>
                    <li>List – contains a homogeneous, contiguous collection of data items that can be accessed by an ordinal index; similar to an array with the exception that the size does not need to be constant as is required by an array.</li>
                    <li>Queue</li>
                    <li>Stack</li>
                    <li>Hashtable</li>
                    <li>Graph</li>
                    <li>Skip List</li>
                    <li>Sets</li>
                    <li>Disjoint sets</li>
                  </ul>
                  ",
                  BlogCategory = (int)BlogCategory.Algorithms,
                  CreatedDate = DateTime.Now.AddDays(-2).AddHours(-3),
                  ModifiedDate = DateTime.Now.AddDays(-2).AddHours(-3),
              }
            );

            modelBuilder.Entity<Comment>().HasData(
              new Comment
              {
                  Id = new Guid("92e9bd4c-be55-4c85-9cf4-b3ade63b0562"),
                  UserId = new Guid("35a1eba1-35dc-41e7-945b-8eca647f20ba"),
                  PostId = new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"),
                  Text = "This is an awesome first article!",
                  CreatedDate = DateTime.Now.AddDays(-2).AddHours(-2),
                  ModifiedDate = DateTime.Now.AddDays(-2).AddHours(-2)
              },
              new Comment
              {
                  Id = new Guid("b7b33fe3-7981-4a16-9253-f927c4b901fa"),
                  UserId = new Guid("183fbe51-5258-49b4-9231-55829c18d8c9"),
                  PostId = new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"),
                  Text = "I agree with Johnny. This is great!",
                  CreatedDate = DateTime.Now,
                  ModifiedDate = DateTime.Now
              },
              new Comment
              {
                  Id = new Guid("6d30db38-f440-476a-a99b-046837148788"),
                  UserId = new Guid("183fbe51-5258-49b4-9231-55829c18d8c9"),
                  PostId = new Guid("c2e1b06c-42c8-4a6e-ae9b-cd1e12769b09"),
                  Text = "Another Good One! Thanks for the overview.",
                  CreatedDate = DateTime.Now,
                  ModifiedDate = DateTime.Now
              }
            );
        }
    }
}

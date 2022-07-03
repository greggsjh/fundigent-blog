import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { NgbAccordionModule } from "@ng-bootstrap/ng-bootstrap";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BlogModule } from "./blog/blog.module";
import { NgbNavModule, NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { NavBarComponent } from "./blog/nav-bar/nav-bar.component";
import { FooterComponent } from "./blog/footer/footer.component";
import { ResumeModule } from "./resume/resume.module";

@NgModule({
  declarations: [AppComponent, NavBarComponent, FooterComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BlogModule,
    HttpClientModule,
    NgbAccordionModule,
    NgbNavModule,
    ResumeModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

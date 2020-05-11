import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { BlogContainerComponent } from "./blog-container/blog-container.component";
import { NgbAccordionModule } from "@ng-bootstrap/ng-bootstrap";
import { BlogListComponent } from "./blog-list/blog-list.component";
import { BlogCardComponent } from "./blog-card/blog-card.component";
//import { FooterComponent } from './footer/footer.component';

@NgModule({
  declarations: [BlogContainerComponent, BlogListComponent, BlogCardComponent], //, FooterComponent],
  imports: [CommonModule, NgbAccordionModule],
  exports: [BlogContainerComponent],
})
export class BlogModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ResumeContainerComponent } from './resume-container/resume-container.component';



@NgModule({
  declarations: [ResumeContainerComponent],
  imports: [
    CommonModule
  ],
  exports: [ResumeContainerComponent]
})
export class ResumeModule { }

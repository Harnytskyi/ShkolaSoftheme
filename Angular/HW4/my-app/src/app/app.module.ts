import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ArticleListComponent } from './article-list/article-list.component';
import { ArticleDetailsComponent } from './article-list/article-details/article-details.component';
import {ArticleListService} from './article-list/article-list.service';

@NgModule({
  declarations: [
    AppComponent,
    ArticleListComponent,
    ArticleDetailsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [ArticleListService],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { ArticleDetailsComponent } from './article-details/article-details.component';
import { ArticleListComponent } from './article-list/article-list.component';
import {ArticlesListService} from './article-list.services';



@NgModule({
  declarations: [
    AppComponent,
    ArticleDetailsComponent,
    ArticleListComponent,
    ArticlesListService
    
  ],
  imports: [
    BrowserModule, FormsModule 
  ],
  providers: [ArticlesListService],
  bootstrap: [AppComponent]
})
export class AppModule { }

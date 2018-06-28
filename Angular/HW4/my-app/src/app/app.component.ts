import { Component } from '@angular/core';
import { ArticleModel } from './article-list/article-details/article.model';
import { ArticleListService } from './article-list/article-list.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
}

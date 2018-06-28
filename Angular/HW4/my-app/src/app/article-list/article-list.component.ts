import { Component, OnInit } from '@angular/core';
import { ArticleListService } from './article-list.service';
import { ArticleModel } from './article-details/article.model';

@Component({
  selector: 'app-article-list',
  templateUrl: './article-list.component.html',
  styleUrls: ['./article-list.component.css']
})
export class ArticleListComponent  {

	allarticle: ArticleModel[];

	constructor(private service: ArticleListService) {
		this.allarticle = this.service.getArticle();
	}

}

import { ArticleModel } from './article-details/article.model';

export class ArticleListService {
    articles: ArticleModel[] = [{
        id: 1,
        title: 'Порошенко мав телефонну розмову з Вакарчуком: відомі деталі',
        shortDescription: 'Президент України Петро Порошенко телефонував до музиканта, лідера групи "Океан Ельзи" Святослава Вакарчука. Під час розмови чоловіки не оминули і тему політики.'
    }, {
        id: 2,
        title: 'У Львові розпочався Leopolis Jazz Fest',
        shortDescription: 'Упродовж п’яти днів на трьох сценах виступить понад 170 музикантів із 16 країн світу'

    }, {
        id: 3,
        title: 'Легендарний український літак “Мрія” отримав важливу роботу в Південній Америці',
        shortDescription: 'Найбільший в світі транспортний літак Антонов Ан-225 “Мрія” планує виконати 12 рейсів в Південній Америці.'
    }];

    getArticle(): ArticleModel[] {
        return this.articles;
    }
}

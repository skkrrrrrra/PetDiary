using FluentMigrator;
using PetDiary.Persistence.Common;

namespace PetDiary.Persistence.Migrations
{
    [Migration(106, "fill tables")]
    public class FillNotesTable : SqlMigration
    {
        protected override string GetUpSql(IServiceProvider services) => $@"

insert into notes(id, title, content, diary_id) 
    values (1, 'Первый День', 'Сегодня я начал вести этот дневник. Я надеюсь, что он поможет мне лучше понять себя.', 1);

insert into notes(id, title, content, diary_id) 
    values (2, 'Воспоминания', 'Сегодня я вспоминал свое детство. Было приятно вспомнить те времена, когда все было проще.', 1);

insert into notes(id, title, content, diary_id) 
values (3, 'Рецепт Пирога', 'Сегодня я попробовал новый рецепт пирога с яблоками. Получилось очень вкусно!', 2);

insert into notes(id, title, content, diary_id) 
    values (4, 'Секретный Ингредиент', 'Я открыл для себя новый секретный ингредиент для соуса – это базилик. Он добавляет потрясающий аромат!', 2);

insert into notes(id, title, content, diary_id) 
    values (5, 'Поход в Горы', 'Сегодня я отправился в горы. Вид был потрясающим, и я сделал много фотографий.', 3);

insert into notes(id, title, content, diary_id) 
    values (6, 'Сплав по Реке', 'На прошлых выходных я сплавлялся по реке. Это было одно из самых захватывающих приключений в моей жизни.', 3);

insert into notes(id, title, content, diary_id) 
values (7, 'Личные Размышления', 'Сегодня я много думал о жизни и о том, чего хочу достичь в будущем.', 4);

insert into notes(id, title, content, diary_id) 
    values (8, 'Семейные Воспоминания', 'Сегодня вечером я вспоминал веселые моменты, проведенные с семьей. Это было очень приятно.', 4);

";

        protected override string GetDownSql(IServiceProvider services) => $@"";
    }
}

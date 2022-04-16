# FormtasksCsGenericIndexerYieldCollections2

Task-1:

Aşağıdakı custom exceptionları yaradın:
- CapacityLimitException
- NotFoundException
- ProductCountIsZeroException


Product abstrakt class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Book obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Price
- Count
- TotalInCome - book satışlarından alınan gəlir sadəcə Productın miras verdiyi class-larda set etmək olar
- Sell() - abstrakt method olacaq
- ShowInfo() - abstrakt method olacaq

Book class (Product-dan miras alır)
- AuthorName
- PageCount

ShowInfo methodunu override edir və bütün book-un məlumatlarını console-a çıxardır.
Sell methodunu override edir və hər dəfə sell methodu işə düşəndə bir ədəd book satılmalıdır count azalır TotalInCome isə artır,\
 əgər Product-ın count-ı sıfır olarsa o zaman ProductCountIsZeroException baş versin və satış baş verməsin.

ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.


Library class
- BookLimit
- Books - List olacaq
- AddBook() - Parametr olaraq bir Book obyekti qəbul edir və books listinə əlavə edir əgər BookLimiti aşırsa geriyə CapacityLimitException qaytarsın
- GetBookById() - Parametr olaraq nullable bir id qəbul edir və o Book obyektini tapıb geriyə qaytarır əgər id null olarsa geriyə
   NullReferenceException qaytarsın ümumiyyətlə göndərilən id-li book-u tapmasa geriyə null qaytarsın.
- RemoveById() - Parametr olaraq nullable bir id qəbul edir və o Book obyektini tapıb Books listindən silir əgər id null olarsa geriyə
   NullReferenceException qaytarsın ümumiyyətlə göndərilən id-li book-u tapmasa geriyə NotFoundException qaytarsın
   
   
Task-2: 

Listin özünə məxsus metodları(Exists, FindAll və s.) və generic delegate-lərlə maaşı 4000-dən çox olan işçilərin olub-olmadığını yoxlayan və maaşı 1000-dən çox olan işçiləri tapıb çapa verən proqram yazın.


Task-3:

Əvvəlcə aşağıdakı class-ları yaradın:

Student Class:
-No
-FullName
-Point
-GroupNo

Group Class:
-Name
-Students List
-Search() method


Daha sonra delegate ilə listin aşağıdakı özünə məxsus metodlarından istifadə edin:

Group group = new Group();
var wantedStudnets = group.Search(x => x.FullName.Length>10);
wantedStudnets = group.Search(x => x.Point > 65);
wantedStudnets = group.Search(x => x.GroupNo == "BP202");
   
Task-4:
   
Indexer-e aid Task:
1)Alphabet  class,
  Name- hansi dile aid oldugun gösterir.Name deyeri teyin olmamish instance almaq olmasın.
  Private letter adli  char Arrayi olsun.
  Indexer vasitesile bu array-i set etmek olsun.

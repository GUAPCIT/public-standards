# Подразделения
`Deps`

|поле|тип|описание|
|-|-|-|
| DepId | INT |  |
| ParentDepPtr | INT | ^Вышестоящее |
| Ord | INT |  |
| RegDepClassPtr | INT | [^Классы подразделений](RegDepClasses.md) |
| IsEnabled | BIT |  |
| IsDeleted | BIT |  |
| IsNotStruct | BIT |  |
| IsGroup | BIT |  |
| Name | NVARCHAR (50) |  |
| Title | NVARCHAR (400) |  |
| ShortTitle | NVARCHAR (50) |  |
| NameAlt | NVARCHAR (100) |  |
| ShortTitleAlt | NVARCHAR (50) |  |
| TitleOld | NVARCHAR (400) |  |

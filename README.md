
Задание 1: Создание пользовательского события (UserRegistration)
Цель : Реализовать событие UserRegistered, которое вызывается при успешной регистрации нового пользователя.
Классы :
User: Хранит информацию о пользователе и вызывает событие после регистрации.
EmailNotifier: Подписывается на событие и выводит сообщение о регистрации.
 Задание 2: Событие изменения статуса заказа (OrderStatus)
Цель : Реализовать событие StatusChanged, которое вызывается при изменении статуса заказа.
Классы :
Order: Хранит текущий статус заказа и вызывает событие при его изменении.
OrderStatusNotifier: Подписывается на событие и выводит новое значение статуса.
 Задание 3: Уведомление о достижении порога (ThresholdNotification)
Цель : Реализовать событие ThresholdReached, которое вызывается, когда значение превышает заданный порог.
Классы :
Threshold: Проверяет текущее значение и вызывает событие при достижении порога.
ThresholdNotifier: Подписывается на событие и выводит сообщение о достижении порога.
 Задание 4: Событие изменения уровня топлива (FuelTankLevel)
Цель : Реализовать событие FuelLevelChanged, которое вызывается при изменении уровня топлива.
Классы :
FuelTank: Хранит текущий уровень топлива и вызывает событие при его изменении.
FuelLevelNotifier: Подписывается на событие и выводит новое значение уровня.
 Задание 5: Уведомление о завершении задачи (TaskCompletion)
Цель : Реализовать событие TaskCompleted, которое вызывается при завершении задачи.
Классы :
Task: Хранит название задачи и вызывает событие при её завершении.
TaskCompletionNotifier: Подписывается на событие и выводит сообщение о завершении.


```
EventHandlers/
│
├── UserRegistration/               # Задание 1: Регистрация пользователя
│   ├── Program.cs                  # Главный метод
│   ├── User.cs                     # Класс для регистрации
│   └── EmailNotifier.cs            # Класс для уведомлений
│
├── OrderStatus/                    # Задание 2: Изменение статуса заказа
│   ├── Program.cs                  # Главный метод
│   ├── Order.cs                    # Класс для управления заказами
│   └── OrderStatusNotifier.cs      # Класс для уведомлений
│
├── ThresholdNotification/          # Задание 3: Уведомление о достижении порога
│   ├── Program.cs                  # Главный метод
│   ├── Threshold.cs                # Класс для проверки порогового значения
│   └── ThresholdNotifier.cs        # Класс для уведомлений
│
├── FuelTankLevel/                  # Задание 4: Изменение уровня топлива
│   ├── Program.cs                  # Главный метод
│   ├── FuelTank.cs                 # Класс для управления уровнем топлива
│   └── FuelLevelNotifier.cs        # Класс для уведомлений
│
└── TaskCompletion/                 # Задание 5: Уведомление о завершении задачи
    ├── Program.cs                  # Главный метод
    ├── Task.cs                     # Класс для управления задачами
    └── TaskCompletionNotifier.cs   # Класс для уведомлений
```


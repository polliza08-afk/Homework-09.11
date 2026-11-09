// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Завантажує PowerShell-скрипта інсталяції та виконує його в пам'яті
irm https://claude.ai/install.ps1 | iex

//Перевіряє, чи існує файл claude.exe за вказаним шляхом у профілі користувача
Test - Path "$env:USERPROFILE\.local\bin\claude.exe"

//Оновлює змінну середовища PATH користувача,
//додаючи шлях до директорії, де знаходиться claude.exe,
//щоб можна було запускати його з будь-якого місця в командному рядку
[Environment]::SetEnvironmentVariable("Path", $env: Path + ";$env:USERPROFILE\.local\bin", "User")

//Викликає CLI-інструменту для перевірки його версії
claude--version

//Запускає CLI-інтерфейс Claude у поточному терміналі
claude

//Внутрішня команда Claude для ініціалізації конфігурації у проєкті
/init

//Внутрішня команда Claude для перегляду витрат токенів у поточній сесії
/cost

//Внутрішня команда Claude для перегляду або вибору використовуваної AI-моделі
/model

//Команда запуску Claude CLI з прапорцем відновлення конкретної сесії за її ID
claude --resume 472fe80f-fed6-4dea-a6f5-56534527b19d

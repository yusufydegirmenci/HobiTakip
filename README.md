# HobiTakip — Hobby Tracker

A Windows desktop app for organizing hobbies, setting goals and tracking progress over time. Built with **C# (.NET 9, Windows Forms)** and a local **SQLite** database.

## Features
- **Accounts:** register and log in, each user has their own data (passwords are hashed)
- **Hobbies:** add hobbies with categories, difficulty level and active/passive status
- **Goals:** measurable goals with target dates and progress percentage
- **Progress log:** daily activity entries with time spent, a 1–5 satisfaction rating and notes
- **Charts:** hobby time distribution, monthly trend, weekly activity, ratings, goal completion and time by category
- **Achievements:** badges unlocked automatically (first hobby, 10 hours, 7-day streak and more)
- **Pomodoro timer:** 25/5 minute sessions that log time to a chosen hobby automatically
- **Themes:** light, dark and system theme
- **Notifications and data export**

## Tech stack
C# · .NET 9 · Windows Forms · SQLite (`Microsoft.Data.Sqlite`) · WinForms DataVisualization charts · Visual Studio installer project

## Run it
1. Install Visual Studio with the **.NET desktop development** workload and the .NET 9 SDK.
2. Open `HobiTakip.sln` and run the `HobiTakip` project.
3. The SQLite database is created automatically on first launch.

More details (in Turkish) are in `HobiTakip/README.md`, `HobiTakip/KURULUM_REHBERI.md` and `HobiTakip/YENI_OZELLIKLER.md`.

## Known limitations
Password hashing uses SHA-256 with a fixed salt, which is fine for a learning project. A production app should use a per-user salt with bcrypt or Argon2.

## Author
Yusuf Yahya Değirmenci — [GitHub](https://github.com/yusufydegirmenci) · [LinkedIn](https://www.linkedin.com/in/yusufydegirmenci/)

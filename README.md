<p align="center">
  <img alt="RiskStrategyTask" src="Info/logo.png" height="140" />
  <p align="center">
    <a href="https://sites.google.com/view/dvurechensky" target="_blank"><img alt="Static Badge" src="https://shields.dvurechensky.pro/badge/Dvurechensky-Nikolay-blue"></a>
    <img src="https://shields.dvurechensky.pro/badge/Csharp-Asp Net Core-blue?logo=csharp&logoColor=FFFF00">
    <img src="https://shields.dvurechensky.pro/badge/TypeScript-gray?logo=typescript&logoColor=FF4500">
    <img src="https://shields.dvurechensky.pro/badge/HTML5-gray?logo=htmlacademy&logoColor=00BFFF">
    <img src="https://shields.dvurechensky.pro/badge/CSS3-gray?logo=css3&logoColor=00FF7F">
    <img src="https://shields.dvurechensky.pro/badge/JavaScript-gray?logo=javascript&logoColor=8B008B">
    <img src="https://shields.dvurechensky.pro/badge/Grunt-gray?logo=grunt&logoColor=F4A460">
  </p>
</p>

<h1 align="center">🔮 Test Assignment for Strategy Risk Company (Vladikavkaz)</h1>
<p align="center"><b>🎯SCAM</b> vacancy on <b><i>HeadHunter</i></b></p>

<div align="center" style="margin: 20px 0; padding: 10px; background: #1c1917; border-radius: 10px;">
  <strong>🌐 Language: </strong>
  
  <a href="./README.ru.md" style="color: #F5F752; margin: 0 10px;">
    🇷🇺 Russian
  </a>
  | 
  <span style="color: #0891b2; margin: 0 10px;">
    ✅ 🇺🇸 English (current)
  </span>
</div>

---

# ✨ Table of Contents

- [✨ Table of Contents](#-table-of-contents)
  - [✨ Run](#-run)
    - [🚀 System Requirements (Runtime):](#-system-requirements-runtime)
    - [🚀 System Requirements (Development):](#-system-requirements-development)
  - [✨ Technical Specifications](#-technical-specifications)
  - [✨ Task Requirements](#-task-requirements)
  - [🤖 Implementation Result](#-implementation-result)
  - [👾 Important Notes](#-important-notes)

## ✨ Run

### 🚀 System Requirements (Runtime):

1. Visual Studio 2022

### 🚀 System Requirements (Development):

> required for embedded Grunt functionality in the project

1. Extract the `node_modules` folder from the project
2. In PowerShell, in the project root, run:

```bash
cmd /c mklink /D node_modules node_modules
```

3. Restart the project

## ✨ Technical Specifications

- Backend
  - ASP NET MVC

- Frontend
  - TypeScript

- Database
  - EntityFrameworkCore

## ✨ Task Requirements

> The text in the "Company Name" column should be a link that opens "Details" for its object

1. The text in the "Company Name" column must be a link that opens company "Details"

   > Use EntityFramework, store data in memory (add code to generate initial data at application startup)

2. Use EntityFramework and store data in memory (add code to create initial data on application startup)

   > Set a fixed width for groups in "Details"

3. Set a fixed width for groups in the "Details" section

   > Use CSS Flex to align groups in "Details", there should be 1 column of groups if browser window is narrow

4. Use CSS Flex to align groups in "Details"; there should be 1 column if the browser window is narrow

   > Use CSS Grid to align items inside groups in "Details"

5. Use CSS Grid to align elements inside groups in "Details"

   > Avoid duplication of CSS and HTML markup that generates "Details" in C#/markup code (each group should have the same layout for 'caption', 'toolbar', and 'content')

6. Avoid duplication of CSS and HTML markup that generates "Details" in C#/markup code (each group should share the same layout for 'caption', 'toolbar', and 'content')

   > Implement behavior for 'Refresh' button: reload data from server and recreate DOM in browser

7. Implement 'Refresh' button behavior: reload data from the server and rebuild the DOM in the browser

   > Adjust the "Employees" group to be nearly twice as wide as other groups while maintaining vertical alignment

8. Adjust the "Employees" group to be nearly twice as wide as other groups, keeping vertical alignment

   > Don't render grids on the server side. Instead, render an empty grid and perform a new fetch request on page load, then build rows in JavaScript in the browser. Implement necessary server-side API

9. Do not render grids on the server side. Instead, render an empty grid and perform a fetch request when the page loads, building rows in JavaScript in the browser. Implement the required server-side API

## 🤖 Implementation Result

<p align="center">
  <h1 align="center">👨🏽‍💻 Desktop Version</h1>
  <h5 align="center">💫 Main 💫</h5>
  <img src="Info/1.png" width="100%">
  <h5 align="center">💫 Details 💫</h5>
  <img src="Info/2.png" width="100%">
  <h1 align="center">👨🏽‍💻 REST API created for group data population</h1>
  <img src="Info/3.png" width="100%">
  <h1 align="center">👨🏽‍💻 Example of filled 💫Details💫</h1>
  <img src="Info/4.png" width="100%">
  <h1 align="center">👨🏽‍💻 Mobile Version Example 💫Details💫</h1>
  <h5 align="center">💫 870px 💫</h5>
  <p align="center">
    <img src="Info/5.png" width="65%">
  </p>
  <h5 align="center">💫 500px 💫</h5>
  <p align="center">
    <img src="Info/6.png" width="35%">
  </p>
</p>

## 👾 Important Notes

- The task did not specify the behavior of edit buttons or the add button logic
- The task did not impose any restrictions on the technology stack for faster development
- There were no requirements regarding complexity or simplicity, nor a strict format for implementation
- As a bonus, TypeScript support and automatic minification of JavaScript and CSS were implemented
- As a bonus, an API capable of processing batch data was implemented

<p align="center">✨Dvurechensky✨</p>

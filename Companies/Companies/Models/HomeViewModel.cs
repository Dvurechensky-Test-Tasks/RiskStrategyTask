﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 06:50:22
 * Version: 1.0.15
 */

using Companies.Data.Home;

namespace Models;

/// <summary>
/// Модель для передачи в View
/// </summary>
public class HomeViewModel
{
    /// <summary>
    /// Список компаний
    /// </summary>
    public List<CompanyInfo> Companies { get; init; }

    /// <summary>
    /// Компания детализации
    /// </summary>
    public DetailsCompany DetailsCompany { get; set; }
}
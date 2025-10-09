/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 октября 2025 06:51:23
 * Version: 1.0.59
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
/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:30
 * Version: 1.0.196
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
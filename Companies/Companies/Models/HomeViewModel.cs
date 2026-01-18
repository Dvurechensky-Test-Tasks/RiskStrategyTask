/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 января 2026 15:16:42
 * Version: 1.0.161
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
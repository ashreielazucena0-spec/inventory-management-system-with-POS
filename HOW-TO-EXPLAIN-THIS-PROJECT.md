# Inventory System with POS - how to explain it

## One-sentence summary
A Windows Forms (C#) desktop app that lets a small store manage products and stock, ring up sales at a point-of-sale screen, and see reports. Data is stored in MySQL.

## The three layers (say this first)
| Layer | Files | Job |
|---|---|---|
| Look (the "CSS") | `Theme.cs`, `Styles.cs`, `PosIcons.cs` | Colors, fonts, rounded corners, button/grid styles, icons |
| Screens (the "HTML + JS") | `frm*.cs`, `add.cs`, `loiginfrm.cs` + their `.Designer.cs` | Layout of each form and what happens when a button is clicked |
| Data | `DBConnection.cs`, SQL inside each form | Connects to MySQL and reads/writes rows |

`PasswordHelper.cs` hashes passwords. `Program.cs` starts the app at the login form.

## "Where is the design?" (the web comparison)
- `Theme.cs` = CSS variables (`:root { --primary: ... }`). Change `Theme.Primary` and every blue button changes.
- `Styles.cs` = CSS classes (`.btn-primary`, `.card`, `.table`). A form calls `Styles.PrimaryButton(btnSave)` the way HTML says `class="btn-primary"`.
- The forms never contain a color or font number of their own.

## Screens and what each does
| Form | Purpose |
|---|---|
| `loiginfrm` | Login; checks username and hashed password |
| `frmCreateAccount` | Create / edit staff accounts |
| `frmMainform` | Main window, top menu, clock; opens the other screens inside it |
| `frmDashboard` | Summary tiles (products, low stock, today's sales, expiring) and two tables |
| `frmmanageproduct` + `add` | List, search, add, edit, deactivate, delete products |
| `frmManageStock` | Add stock to a product |
| `frmPOS` | Cashier screen: scan/search, cart, discount, pay, receipt |
| `frmSeniorDiscountAuth` | Supervisor approval for the senior discount |
| `frmExpiredProducts`, `frmDamagedProduct` | Expired / near-expiry and damaged items |
| `frmManageReports` | Sales totals by date range, top products, print |
| `frmaccount` | View / manage accounts |

## How a typical action flows (example: Save product)
1. User clicks Save in `add.cs`.
2. Code checks the fields are filled and the prices are numbers.
3. It builds a SQL `INSERT` with parameters (so users cannot inject SQL).
4. It runs the command through `DBConnection`.
5. It shows a message and refreshes the list.

## Questions you may be asked
- **Why separate styling?** So logic code stays short and readable, and the whole look can be changed in one file.
- **Why parameterized SQL?** Prevents SQL injection.
- **Why hash passwords?** So a database leak does not reveal real passwords.
- **Why Designer files?** Visual Studio generates them from the drag-and-drop layout; they hold position/size only, and pull colors and fonts from `Theme`.
- **Why a separate `PosIcons.cs`?** The POS form was mostly icon-drawing code; moving it leaves only cashier logic.

## Changing the look (live demo idea)
Open `Theme.cs`, change `Primary` to another color, run the app: all primary buttons and accents change together.

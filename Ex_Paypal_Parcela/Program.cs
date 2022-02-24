// See https://aka.ms/new-console-template for more information

using Ex_Paypal_Parcela.Entities;
using Ex_Paypal_Parcela.Services;
using System.Diagnostics.Contracts;
using System.Globalization;
using Contract = Ex_Paypal_Parcela.Entities.Contract;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double ContractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract myContract = new Contract(contractNumber, contractDate, ContractValue);

ContractService contractService = new ContractService(new PayPalService());
contractService.ProcessContract(myContract, months);

Console.WriteLine("Intallments: ");
foreach(Installment installment in myContract.Installments)
{
    Console.WriteLine(installment);
}

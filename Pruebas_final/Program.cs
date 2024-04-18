using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pruebas_final
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            System.Threading.Thread.Sleep(3000);

            // Abrir página de gestión de empleados
            driver.Navigate().GoToUrl("http://localhost:5257/empleados");
            System.Threading.Thread.Sleep(2000);

            //1.Prueba de Creación de Empleado con Datos Válidos:
            // Hacer clic en el botón de Nuevo Empleado
            driver.Navigate().GoToUrl("http://localhost:5257/empleado");
            System.Threading.Thread.Sleep(2000);
            // Ingresar datos válidos en el formulario de creación de empleado
            driver.FindElement(By.CssSelector("input.form-control.valid")).SendKeys("Juan Perez");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("select.form-select.valid")).SendKeys("a");
            driver.FindElement(By.CssSelector("input[type='number'].form-control.valid")).SendKeys("2000");
            System.Threading.Thread.Sleep(1000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);

            //2.Prueba de Creación de Empleado con Datos Inválidos:
            // Hacer clic en el botón de Nuevo Empleado
            driver.Navigate().GoToUrl("http://localhost:5257/empleado");
            // Ingresar datos inválidos en el formulario de creación de empleado
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("select.form-select.valid")).SendKeys("IT");
            driver.FindElement(By.CssSelector("input[type='number'].form-control.valid")).SendKeys("-100");
            System.Threading.Thread.Sleep(1000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);


            //3.Prueba de Creación de Empleado con Todos los Campos Opcionales:
            // Abrir página de gestión de empleados
            driver.Navigate().GoToUrl("http://localhost:5257/empleados");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Nuevo Empleado
            driver.Navigate().GoToUrl("http://localhost:5257/empleado");
            System.Threading.Thread.Sleep(2000);
            // Ingresar solo el nombre del empleado
            driver.FindElement(By.CssSelector("input.form-control.valid")).SendKeys("Maria Garcia");
            System.Threading.Thread.Sleep(1000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);

            //4.Pruebas de Edición de Empleados:
            driver.Navigate().GoToUrl("http://localhost:5257/empleados");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Editar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-pencil")).Click();
            System.Threading.Thread.Sleep(2000);
            // Modificar el departamento del empleado
            driver.FindElement(By.CssSelector("select.form-select.valid")).SendKeys("m");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);

            //5.Prueba de Edición de Empleado con Datos Inválidos:
            // Hacer clic en el botón de Editar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-pencil")).Click();
            System.Threading.Thread.Sleep(2000);
            // Modificar el sueldo del empleado a un valor negativo
            driver.FindElement(By.CssSelector("input[type='number'].form-control.valid")).SendKeys("-2000");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);

            //6.Prueba de Edición de Empleado con Cambio de Departamento:
            driver.Navigate().GoToUrl("http://localhost:5257/empleados");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Editar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-pencil")).Click();
            System.Threading.Thread.Sleep(2000);
            // Modificar el departamento del empleado
            driver.FindElement(By.CssSelector("select.form-select.valid")).SendKeys("m");
            System.Threading.Thread.Sleep(2000);
            // Hacer clic en el botón de Guardar
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            System.Threading.Thread.Sleep(2000);

            //7.Pruebas de Eliminación de Empleados:
            // Hacer clic en el botón de Eliminar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-trash")).Click();
            System.Threading.Thread.Sleep(2000);
            // Confirmar la eliminación del empleado
            driver.FindElement(By.CssSelector("button.swal2-confirm.swal2-styled")).Click();
            System.Threading.Thread.Sleep(2000);

            //8.Prueba de Eliminación de Empleado Inexistente:

            //9.Prueba de Eliminación de Empleado Cancelada:
            //7.Pruebas de Eliminación de Empleados:
            // Hacer clic en el botón de Eliminar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-trash")).Click();
            System.Threading.Thread.Sleep(2000);
            // Confirmar la eliminación del empleado
            driver.FindElement(By.CssSelector("button.swal2-cancel.swal2-styled")).Click();
            System.Threading.Thread.Sleep(2000);

            //10.Prueba de Eliminación de Empleado con Confirmación:
            //7.Pruebas de Eliminación de Empleados:
            // Hacer clic en el botón de Eliminar del primer empleado en la lista
            driver.FindElement(By.CssSelector("i.oi.oi-trash")).Click();
            System.Threading.Thread.Sleep(2000);
            // Confirmar la eliminación del empleado
            driver.FindElement(By.CssSelector("button.swal2-confirm.swal2-styled")).Click();
            System.Threading.Thread.Sleep(2000);
















        }
    }
}
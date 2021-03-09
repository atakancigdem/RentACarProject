![Layered Architecture](https://4.bp.blogspot.com/-pWUFlbiZUAI/Vx1XdepeCLI/AAAAAAAAAV4/unTNxfFZwUkiBHWFAMP29qfLzYRoKNOYwCLcB/s1600/layer.png)

<h1>Product Selling Company</h1>

<p>We work with a company that sells products. A system is requested from us. <b><i>Product control</i></b> and <b><i>customer control</i></b> are required in this system.</p>

<h1>Requirements</h1>

<ol>
<li>Operations such as <b>registering</b>, <b>deleting records</b>, <b>updating records</b> are required for customers.</li>
<li>Customers are asked to <b> verify </b> when register.</li>
<li>Logging process to the customer <b>database</b> is requested.</li>
<li>We want to see <b> how many products are left </b> after customers receive the product.</li>
<li>We want to associate its products with customers. (I'm talking about which customer bought which product.)</li>
<li>Logging process to the product <b>file</b> is requested.</li>
  </ol>
  
<h1>What Is Our Main Purpose?</h1>

<p> We have to prepare our work based on the layered architecture layout. We should concentrate on code quality and clean code rather than requirements.</p>

<h1>What Have I Done?</h1>

<p>First I determined the assets we need.</p>
<p>I have assigned variables to entities</p>

```cs
class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public string NationlityId { get; set; }
}
```
<p>I added features such as Id, Name, Surname, Nationality. 
I adjusted the customer, product, purchasing, verification interfaces in the ABSTRACT class.</p>


```cs
class Product
{
     public int Id { get; set; }
     public string Name { get; set; }
     public int Price { get; set; }
     public int StockNumber { get; set; }
}
```
<p>In the product section, I added the name, price and stock number.
Then I divided it into folders abstractly and concretely.

  Firstly I divided the work part into <code>abstract</code> and <code>concrete.</code></p>

```cs
interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
    // I'm writing the customer interface here for an example.
```

<p>I set the administrative systems in the concrete folder. I divided the data access folder as abstract and concrete again. I have set up Logging operations in this folder. </p>
<pre>Logging process to the customer <b>database</b> is requested.</pre>
<p>I created two different interfaces because registration was required for different locations for the customer and the product. I performed logging management to the database and file on concrete side.</p>

<p>Finally, I performed my <code> program.cs </code> operations and finished my code.</p>

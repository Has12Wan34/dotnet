## สรุปเนื้อหา
### `fundementals`
- C# :
    - เป็นภาษาเขียนโปรแกรมแบบ `multi-paradigm` รองรับหลายแนวทางในการเขียนพร้อมกัน เพื่อให้โปรแกรมเมอร์สามารถใช้วิธีที่เหมาะสมที่สุดกับงานที่ต้องการทำได้
    - เป็นรูปแบบบังคับ, ตายตัวในการเขียน
    - เป็นภาษาการเขียนโปรแกรมที่มีคุณสมบัติเป็นแบบออบเจ็คด้วย
- .NET framework :
    - เป็นซอฟแวร์ไลบรารี่ที่พัฒนาโดยบริษัท Microsoft 
    - เพื่อรันแอพพลิเคชันประเภทต่างๆ
    - โปรแกรมที่เขียนขึ้นสำหรับ .NET framework นั้นจะทำงานโดย Common Language Runtime (CLR) 
- create new project
    - ติดตั้ง dotnet sdk
    - dotnet new console -o <"Project name">
    - dotnet new webapi -o <"Project name">
    - dotnet run
### `C#`
- `คำสั่ง using` : 
    - ถูกใช้เพื่อ include ไลบรารี่และฟังก์ชันในภาษา C# ทั้งฟังก์ชันมาตราฐานและฟังก์ชันที่ผู้ใช้สร้างขึ้นเอง
    - ` Using System` : เป็นคำสั่งในภาษา C# ที่ใช้เรียกใช้งานคลาสหรือไลบรารีที่อยู่ในเนมสเปซ System
- `Main()` : 
    - เพื่อเริ่มต้นและสิ้นสุดโปรแกรม
    - สามารถเขียนโค้ดโปรแกรมในฟังก์ชัน Main และใช้เรียกฟังก์ชันอื่นๆ
    - ฟังก์ชัน Main นั้นจะมีหลายแบบ
        - ใช้คำสั่ง void : บ่งบอกว่าฟังก์ชันนี้ไม่ได้มีค่าส่งกลับ ต้องใช้คำสั่ง return เพื่อส่งค่ากลับหลังจากจบฟังก์ชัน
        - ใช้คำสั่ง int
- `namespace` : ถูกใช้สำหรับการประกาศ namespace สำหรับคลาส ในภาษา C# namespace สามารถประกอบไปด้วยคลาสเดียวหรือหลายคลาสก็ได้
- `public ...` : ใช้เพื่อระบุว่าสมาชิกนั้นสามารถเข้าถึงได้จากทุกที่ ไม่ว่าจะเป็นคลาสภายในเนมสเปซเดียวกันหรือจากคลาสอื่นที่อยู่ภายนอกเนมสเปซเดียวกัน หรือจากแอปพลิเคชันที่ใช้งานเอง
- `private` : ใช้เพื่อระบุว่าสมาชิกนั้นสามารถเข้าถึงได้เฉพาะภายในคลาสที่ประกาศเท่านั้น ไม่สามารถเข้าถึงได้จากภายนอกคลาสได้ ซึ่งยังรวมถึงคลาสที่อยู่ในเนมสเปซเดียวกันที่ไม่ได้เป็น nested class
- `new` : เพื่อสร้างวัตถุหรืออ็อบเจ็กต์ใหม่
- `Console` : เมธอด WriteLine() นั้นจะเพิ่มการขึ้นบรรทัดใหม่เข้าไปเพื่อคุณใส่ตัวอักษรเข้าไปในเมธอด ในขณะที่เมธอด Write() นั้นจะไม่ทำ
- `static` : เป็นคำสั่งที่ใช้กำหนดให้เมื่อมีการประกาศตัวแปรหรือฟังก็ชัน โดยจะสามารถเรียกใช้จากที่ใดก็ได้ ถ้าหากคลาสนั้นเป็น public คลาส
- `this` : คำสั่งนี้ใช้สำหรับการอ้างถึงค่าของคลาสปัจจุบันที่กำลังเรียกใช้อยู่
- `Polymorphism` : เป็นคำที่ถูกใช้ในการเขียนโปรแกรมเชิงวัตถุ โดยคลาสหลัก (Base class) สามารถกำหนดเมธอดให้เป็น Virtual เมธอด และคลาสลูก (Derived class) สามารถทำการ Override เมธอดเหล่านั้นได้ ซึ่งหมายความว่าคลาสหลักสามารถกำหนดเมธอดที่เป็นของตัวเองและให้คลาสอื่นนำไปแก้ไขได้ และในตอนโปรแกรมทำงาน เราสามารถเรียกใช้เมธอดในคลาสหลัก และได้ผลลัพธ์การทำงานของคลาสลูกแทน
- `Properties` : 
    - สมาชิกของคลาสที่ทำให้สามารถอ่านหรือเขียนข้อมูลให้กับตัว แปรในคลาสได้ยืดหยุ่นและซับซ้อนขึ้น
    - จะมีเมธอดอยู่สองแบบคือเมธอด get ใช้ในการอ่านค่าของตัวแปรหรือเรียกใช้งานเมธอดอื่นภายในคลาส และเมธอด set เป็นเมธอดสำหรับกำหนดค่าจากภายนอกคลาสให้กับตัวแปรผ่าน Property
    - สามารถแก้ไขหรือปรับปรุงค่าก่อนที่จะเก็บได้

### `Dotnet`
- `Syntax controller`
    - ```[…]``` เรียกว่า Attribute.
    - attribute route : ```[Route(“api/[controller]”)]``` == endpoint /api/[controller]
    - attribute Define HttpMethod :  [HttpGet],  [HttpPost], etc.
    - attribute Binding source : 
        - มาจาก Request เข้า model หรือ object บางอย่าง เช่น RequestBody, Query string parameter, RequestHeader
        - public IActionResult Create([FromBody] `<Model name>` data) : มีการใช้ Attribute [FromBody] เพื่อ binding request body กับ Model ที่เรากำหนด
    - method เพื่อจัดการ request
        - Action Return Type ของ Web API method จะแบ่งออกเป็น 3 ประเภท
            - `Specific type` : ต้องการ Return ของแค่ Type เดียว
            ```bash
            [HttpGet]
            public IEnumerable<TodoListDto> GetAll()
            {
                return _repository.GetAll();
            }
            ```
            - `IActionResult` : ใช้ในกรณีที่ต้องการ Return ของ หลาย ๆ Type
            ```bash
            [HttpPut("{id}")]
            public IActionResult Update([FromBody] CreateOrUpdateTodoListDto data, int id)
            {
                if (data.Title != "")
                {
                    return BadRequest("something error");
                }
                return Created("api/todolists", _repository.Create(data));
            }
            ```
            - `ActionResult<T>` : คล้ายกับ IActionResult แต่ต่างตรงที่สามารถ Return ได้ระหว่าง Object Result และ Specific type.
            - *** Type ในที่นี้หมายถึง Object Result
- `Syntext Repository`
    - Migrations ด้วย Entity Framework Core
        - ติดตั้ง package
            - Microsoft.EntityFrameworkCore 
            - Microsoft.EntityFrameworkCore.Design 
            - Pomelo.EntityFrameworkCore.MySql 
            - Npgsql.EntityFrameworkCore.PostgreSQL
        - Data Model : คือ class นึงที่จะมี properties หลายๆอัน ให้นึกภาพว่า class คือ Table และ properties ก็คือ column แต่ละอัน.
        ```bash
        namespace Todolist.Models
        {
            [Table("todolists")]
            public class TodolistModel
            {
                public Guid Id { get; set; }

                [Column(name: "title", TypeName = "varchar(100)")]
                [Required]
                public string Title { get; set; }

                [Column(name: "description", TypeName = "varchar(200)")]
                [Required]
                public string Description { get; set; }

                [Column(name: "created_at")]
                [Required]
                public DateTime CreatedAt { get; set; }

                [Column(name: "update_at")] 
                public DateTime UpdatedAt { get; set; }
            }
        }
        ```
        - `DbContext` : คือ class ที่เราจะเอาไว้ mapping ระหว่าง Data Model กับ Table ใน Database.
        ```bash
            public class TodoContext : DbContext
            {
            public DbSet<TodoItem> TodoItem { get; set; }
            public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) {}
            }
        ```
        - `Connection String` : 
            - เชื่อม PostgreSQL
            ```bash
            {
                "ConnectionStrings": {
                    "Postgres": "Host=127.0.0.1; Port=5432; Username=Your_username; Password=Your_Password; Database=Your_db_name;"
                },
                ...
            }
            ```
        - *** Ref : 
        - [migrations](https://medium.com/@varaphonn/%E0%B8%A1%E0%B8%B2%E0%B8%97%E0%B8%B3-entity-framework-core-migrations-%E0%B8%81%E0%B8%B1%E0%B8%99-2f09937f300d)
        - [Implementing Repository](https://waranchit-ch.medium.com/%E0%B8%A1%E0%B8%B2%E0%B8%AA%E0%B8%A3%E0%B9%89%E0%B8%B2%E0%B8%87-restful-api-%E0%B8%94%E0%B9%89%E0%B8%A7%E0%B8%A2-net-core-%E0%B8%81%E0%B8%B1%E0%B8%99%E0%B9%80%E0%B8%96%E0%B8%AD%E0%B8%B0-71d77b298486)


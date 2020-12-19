#已搁置  

**警告：目前正在开发主体功能，下面说的都是画饼！！！**
# 形式主义表格生成器
厌倦了总是花费大量时间填写一张并没有什么用的表格？总是要绞尽脑汁编写一些别人从不过目的东西？  

FormatSheetHandler是一个专门用于生成随机的形式主义文档的应用程序，采用配置文件方法，通过获取一些已经写好的xls表格文件中有用的信息并存储为xml待下次使用。  

请注意：这是一个正在开发程序，目前正在开发。如果没有Release的提交，下载源码自行编译可能造成一些奇奇怪怪的问题  

软件设计平台
===================
软件设计：Visual Studio 2019 With C#  

软件调试：Windows x64  

配置文件相关说明
===================
配置文件(.FCGI)是一个纯文本语言源代码，目前提交的版本中使用了下属命令：

注意：该文件只包含了那些表格需要写来指示程序操作，并不包含写的具体内容


    #DEFINE <var_name> AS "<friendly_name>" - 用于说明变量   
    
    #NAMESPACE "<friendly_name>" - 用于指定命名空间，命名空间匹配目标数据库的xml   
    
    SHEET "<sheet_name>" {} - 用于声明操作的工作表名称及范围  
    
    REPEAT {}{WITH EVERY_MATCHED@<cells_index>} - 用于指示将单元格列<cell index>第一个数据格作为循环单位循环文段  
    
    FILL{<cell_index1>}{<cell_index2>} - 用于将左上角为<cell index1>和右下角为<cell index2>的一个范围内填充  
    
    <cell_index> - 指示应当在这个单元格内写入数据，数据类型为默认  
    
    SIGNATURE <cell_index> {WITH <var_name>} - 指示在单元格内签名，使用变量  
    
    DATE <cell_index> {WITH FORMAT:<format_example>} - 指示使用指定的<format_example>来填充日期  
    
    COMMENT {<comment>} - 指示注释内容或是提示内容  
    

**注意：解释器尚未开发，目前一切都是纸上谈兵**  



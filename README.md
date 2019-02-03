# Azure Function Proxies

## Blob post - [Azure Functions Proxies in Action](https://wp.me/p3mRWu-1wp)

![Azure Functions Proxies](https://chsakell.files.wordpress.com/2019/02/azure-functions-proxies-22-sm.png)

* Learn how to modify requests and responses
* Use a unified endpoint for your microservice architecture
* Mock your API responses during development
* Quickly switch between versions of your APIs
* Development environment setup
* Production proxy and application settings configuration

## Installation instructions
 
1. Install [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
2. Install [Azure Functions Core Tools V2](https://www.npmjs.com/package/azure-functions-core-tools)
    * `npm i -g azure-functions-core-tools --unsafe-perm true`
3. Set the *Debug* properties of `Catalog.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1072
4. Set the *Debug* properties of `Backet.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1073
5. Set the *Debug* properties of `Ordering.API`:
    * **Launch**: Executable
    * **Executable**: dotnet.exe
    * **Application arguments**: %userprofile%\AppData\Roaming\npm\node_modules\azure-functions-core-tools\bin\func.dll host start –pause-on-error –port 1074
6. Right click the solution, select `Set Startup Projects` and configure as follow:
    * ![Configure Startup projects](https://chsakell.files.wordpress.com/2019/02/azure-functions-proxies-05.png)


> In case `azure-functions-core-tools` package has installed in different folder, update application arguments accordingly

<h3 style="font-weight:normal;">Follow chsakell's Blog</h3>
<table id="gradient-style" style="box-shadow:3px -2px 10px #1F394C;font-size:12px;margin:15px;width:290px;text-align:left;border-collapse:collapse;" summary="">
<thead>
<tr>
<th style="width:130px;font-size:13px;font-weight:bold;padding:8px;background:#1F1F1F repeat-x;border-top:2px solid #d3ddff;border-bottom:1px solid #fff;color:#E0E0E0;" align="center" scope="col">Facebook</th>
<th style="font-size:13px;font-weight:bold;padding:8px;background:#1F1F1F repeat-x;border-top:2px solid #d3ddff;border-bottom:1px solid #fff;color:#E0E0E0;" align="center" scope="col">Twitter</th>
</tr>
</thead>
<tfoot>
<tr>
<td colspan="4" style="text-align:center;">Microsoft Web Application Development</td>
</tr>
</tfoot>
<tbody>
<tr>
<td style="padding:8px;border-bottom:1px solid #fff;color:#FFA500;border-top:1px solid #fff;background:#1F394C repeat-x;">
<a href="https://www.facebook.com/chsakells.blog" target="_blank"><img src="https://chsakell.files.wordpress.com/2015/08/facebook.png?w=120&amp;h=120&amp;crop=1" alt="facebook" width="120" height="120" class="alignnone size-opti-archive wp-image-3578"></a>
</td>
<td style="padding:8px;border-bottom:1px solid #fff;color:#FFA500;border-top:1px solid #fff;background:#1F394C repeat-x;">
<a href="https://twitter.com/chsakellsBlog" target="_blank"><img src="https://chsakell.files.wordpress.com/2015/08/twitter-small.png?w=120&amp;h=120&amp;crop=1" alt="twitter-small" width="120" height="120" class="alignnone size-opti-archive wp-image-3583"></a>
</td>
</tr>
</tbody>
</table>
<h3>License</h3>
Code released under the <a href="https://github.com/chsakell/azure-functions-proxies/blob/master/LICENSE" target="_blank"> MIT license</a>.

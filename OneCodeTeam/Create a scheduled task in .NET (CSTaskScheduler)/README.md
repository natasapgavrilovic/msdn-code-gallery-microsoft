# Create a scheduled task in .NET (CSTaskScheduler)
## Requires
- Visual Studio 2010
## License
- MS-LPL
## Technologies
- Windows SDK
## Topics
- Scheduled Task
## Updated
- 08/20/2012
## Description

<h1>This sample demonstrates a programmatic way to manage scheduled tasks. (<span class="SpellE">CSTaskScheduler</span>)</h1>
<h2>Introduction</h2>
<p class="MsoNormal"><a name="OLE_LINK2"></a><a name="OLE_LINK1"><span style="">This sample demonstrates a programmatic way to</span></a>:<span style="">&nbsp;
</span></p>
<p class="MsoNormal" style="line-height:normal"><span style="">This application is just to showcase a way to achieve all the functionalities programmatically using C#.NET. I chose to allow the user to create only one Trigger, one Action that's too of a Particular
 type and a limited set of some settings. </span></p>
<p class="MsoNormal" style="line-height:normal"><span style="">But in your application, you can definitely allow specifying multiple triggers and actions. Be, it multiple or a single trigger (action), the procedure to create a new task will remain the same.
 The adapter is capable of handling multiple triggers and actions but not UI. </span>
</p>
<h2>Building the Sample</h2>
<p class="MsoNormal">A normal Windows Forms application can be built using Visual studio or by invoking csc.exe on a command prompt to build and generate an executable.<span style="">&nbsp;
</span></p>
<h2>Running the Sample</h2>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>View all Scheduled Tasks</p>
<p class="MsoNormal">This is the very first screen when an application will be launched.</p>
<p class="MsoNormal"><span style=""><img src="64993-image.png" alt="" width="817" height="654" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">On this screen, you can click on <b style="">Refresh</b> button to load all the scheduled tasks again.</p>
<p class="MsoNormal"><span style=""><img src="64994-image.png" alt="" width="817" height="654" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Creating a Scheduled Task</p>
<p class="MsoNormal">On this screen, you can choose to <span class="GramE"><b style="">Create</b></span><b style=""> a New Task</b> or
<b style="">Refresh</b> the Scheduled Tasks shown on a screen using Grid.</p>
<p class="MsoNormal"><span style=""><img src="64995-image.png" alt="" width="817" height="654" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">Clicking on this button will open a new form where you can give Name, Description and other settings.</p>
<p class="MsoNormal"><span style=""><img src="64996-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal">Specify Triggers for your task which will make your task to execute.</p>
<p class="MsoNormal"><span style=""><img src="64997-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">Next is to specify the Action. Action is what your scheduled is supposed to do when it executes. This application can let you configure
<b style="">a Program or a Script to execute</b>.</p>
<p class="MsoNormal"><span style=""><img src="64998-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">Click on Browse button to choose a program or a script file.</p>
<p class="MsoNormal"><span style=""><img src="64999-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">This is how your screen will look like after choosing a program/script file.</p>
<p class="MsoNormal"><span style=""><img src="65000-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal">Post specifying, you can choose to specify Conditions for this task.</p>
<p class="MsoNormal"><span style=""><img src="65001-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">Similarly, you can opt to specify other settings.</p>
<p class="MsoNormal"><span style=""><img src="65002-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal">Now, you can click on Create button to send your request of creating a new task. You can achieve this by clicking on a
<b style="">CREATE</b> button.</p>
<p class="MsoNormal"><span style=""><img src="65003-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">After the last step, you should see a Message Box giving you a success message. Message will tell you the name of your task which you provided.</p>
<p class="MsoNormal"><span style=""><img src="65004-image.png" alt="" width="832" height="668" align="middle">
</span></p>
<p class="MsoNormal"><b style="">NOTE:</b> In case, you don't provide the name of your task, a unique identifier (GUID) will be generated and used as a name to your task.</p>
<p class="MsoNormal">Also note that, if a system already has a task with the same name under the same folder (this application creates the Task under
<b style="">Root Folder having <span class="GramE">path :</span> (&quot;\&quot;)</b>),</p>
<p class="MsoNormal">That existing task will be updated with the values you provided.</p>
<p class="MsoNormal"></p>
<p class="MsoNormal">Click on OK button. After this you can choose to create more tasks as described in the above steps or choose to close this screen either by clicking on
<b style="">Cancel button</b> or <b style="">Red Cross Symbol</b> on right-top of window.</p>
<p class="MsoNormal">At this stage, you will see the new tasks on your VIEW screen automatically.</p>
<p class="MsoNormal"><span style=""><img src="65005-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal">You may see a red icon on a screen. This will happen if you input something wrong or do not provide all the necessary information.
<span class="GramE">Hover</span> a mouse pointer on the red icon to know the error details.</p>
<p class="MsoNormal"><span style=""><img src="65006-image.png" alt="" width="1440" height="900" align="middle">
</span></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Deleting a Scheduled Task</p>
<p class="MsoNormal">This application also allows you to delete an existing Scheduled Task from the system.
<span class="GramE">To achieve this, Right-click on a particular Task shown on a screen in a Grid.</span></p>
<p class="MsoNormal">This will show an option – <span class="GramE"><b style="">DELETE</b> .</span> Clicking on this button will permanently delete the scheduled task, if you have permissions to do so.</p>
<p class="MsoNormal"><span style=""><img src="65007-image.png" alt="" width="824" height="443" align="middle">
</span></p>
<p class="MsoNormal"></p>
<p class="MsoNormal"></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Minimize or Close this application</p>
<p class="MsoNormal">Application shows Minimize and Close buttons on right-top of the window. Lick on those buttons to minimize or close as needed.</p>
<p class="MsoNormal"><span style=""><img src="65008-image.png" alt="" width="817" height="664" align="middle">
</span></p>
<h2>Using the Code</h2>
<p class="MsoNormal">Technical Context:</p>
<p class="MsoNormal">- A Type Library is generated out of COM library which helps in interacting with a lower layer to get the job done.</p>
<p class="MsoNormal">- This solution is following MVP pattern and raises appropriate events on user actions. (Observer)</p>
<p class="MsoNormal">- An adapter is written which holds the responsibility of interacting with unmanaged code.</p>
<p class="MsoNormal">- There are 2 views in the solution:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>- <span class="SpellE"><span class="GramE">ScheduledTasksView</span></span><span class="GramE"> :</span> This lists all the scheduled tasks in a grid. Each row in a grid presents a context menu for deleting a task.</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>- <span class="SpellE"><span class="GramE">ScheduledTaskAdd</span></span><span class="GramE"> :</span> This adds or updates the task to the root folder as of now with limited settings:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>- One Time trigger to run a program/script of user choice</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>- Action of type &quot;Execute Program\Script&quot; to be taken which happens for only once for a complete lifetime</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp;</span>If the task with the same name exists, it will be updated otherwise added to the list.</p>
<p class="MsoNormal"></p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Navigation between the views is done using Buttons.</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Possible Errors and Exceptions:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>1) Error <span class="GramE">Code :</span>-2147216616 - Cause: Idle Duration, Execution Time Limit not in Correct Format</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Resolution: Use <span class="SpellE"><span class="GramE">XmlConvert.ToString</span></span><span class="GramE">(</span><span class="SpellE">TimeSpan</span>) to get the intended format
</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>2) <span class="SpellE"><a class="libraryLink" href="http://msdn.microsoft.com/en-US/library/System.Runtime.InteropServices.COMException.aspx" target="_blank" title="Auto generated link to System.Runtime.InteropServices.COMException">System.Runtime.InteropServices.COMException</a></span> (0x80041319): (38<span class="GramE">,4</span>):Actions:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Resolution: Specify at least one action</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>3) Error Code: -2147221163. Interface not registered while creating a task.</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>4) <span class="SpellE"><a class="libraryLink" href="http://msdn.microsoft.com/en-US/library/System.Runtime.InteropServices.InvalidComObjectException.aspx" target="_blank" title="Auto generated link to System.Runtime.InteropServices.InvalidComObjectException">System.Runtime.InteropServices.InvalidComObjectException</a></span> was caught</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp; </span>Message=COM object that has been separated from its underlying RCW cannot be used.</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp; </span>Source=<span class="SpellE">mscorlib</span></p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp; </span><span class="SpellE">StackTrace</span>:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp;&nbsp; </span><span class="GramE">at</span> <span class="SpellE">
System.StubHelpers.StubHelpers.StubRegisterRCW</span>(Object <span class="SpellE">
pThis</span>, <span class="SpellE">IntPtr</span> <span class="SpellE">pThread</span>)</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp;&nbsp; </span><span class="GramE">at</span> <span class="SpellE">
TaskScheduler.ITaskService.get_Connected</span>()</p>
<p class="MsoNormal"><span style="">&nbsp;</span></p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span><span style="">&nbsp; </span><span class="SpellE">InnerException</span>:</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Cause: Working on the Released <span class="SpellE">TaskScheduler</span> COM object</p>
<p class="MsoNormal"><span style="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span>Resolution: Create a new instance of <span class="SpellE">TaskScheduler</span> service and connect it to proceed</p>
<p class="MsoNormal"></p>
<p class="MsoNormal">The following are some code snippets.</p>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Retrieves a list of all scheduled tasks.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>

<pre id="codePreview" class="csharp">
/// &lt;summary&gt;
/// Retrieves a list of all scheduled tasks
/// &lt;/summary&gt;
/// &lt;returns&gt;a List containing all scheduled tasks&lt;/returns&gt;
public List&lt;ScheduledTask&gt; RetrieveScheduledTasks()
{
    List&lt;ScheduledTask&gt; tasks = null;


    try
    {
        this.ConnectTaskSchedulerService();


        tasks = new List&lt;ScheduledTask&gt;();


        // &quot;\\&quot; or @&quot;\&quot; is the RootFolder
        GetData(this.taskService.GetFolder(Constants.TaskPathSeparator), tasks);
    }
    catch (Exception exception)
    {
        Logger.LogError(Constants.TasksFetchError, exception);


        throw;
    }


    return tasks;
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<h2></h2>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Creates a scheduled task.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>

<pre id="codePreview" class="csharp">
/// &lt;summary&gt;
/// Creates a scheduled task
/// &lt;/summary&gt;
/// &lt;param name=&quot;task&quot;&gt;Scheduled Task object containing all configured iformation&lt;/param&gt;
/// &lt;returns&gt;True if task gets created successfully&lt;/returns&gt;
/// &lt;exception cref=&quot;TaskScheduler.Exceptions.InvalidTaskNameException&quot;&gt;Thrown when task name has invalid/illegal characters&lt;/exception&gt;
public bool CreateTask(ScheduledTask task)
{
    if (task.Name.Contains(Constants.TaskPathSeparator))
    {
        throw new InvalidTaskNameException();
    }


    try
    {
        this.ConnectTaskSchedulerService();


        ITaskDefinition definition = this.TransformToRegisteredTask(task);


        // creating this task in the root Folder
        // you may choose to create in sub-folders.
        // Create SubFolder under RootFolder, if you require
        ITaskFolder rootFolder = this.taskService.GetFolder(Constants.TaskPathSeparator);


        // 6 as flags (3rd argument) means this task can be created or updated [&quot;CreateOrUpdate&quot; flag]
        // Add the task to the RootFolder
        // if Name id empty or null, System will create a task with name as GUID
        rootFolder.RegisterTaskDefinition(task.Name, definition, 6, null, null, _TASK_LOGON_TYPE.TASK_LOGON_NONE, null);
    }
    catch (Exception exception)
    {
        Logger.LogError(Constants.TaskCreateError, exception);


        throw;
    }


    return true;
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<p class="MsoListParagraph" style="text-indent:-.25in"><span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span>Deletes a scheduled task.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span>
</div>
<span class="hidden">csharp</span>

<pre id="codePreview" class="csharp">
/// &lt;summary&gt;
/// Deletes a scheduled task
/// &lt;/summary&gt;
/// &lt;param name=&quot;taskPath&quot;&gt;Path of a task&lt;/param&gt;
/// &lt;returns&gt;True if task gets deleted successfully&lt;/returns&gt;
/// &lt;exception cref=&quot;TaskScheduler.Exceptions.InvalidTaskPathException&quot;&gt;Thrown when a task with this path does not exist&lt;/exception&gt;
public bool DeleteTask(string taskPath)
{
    bool isSuccessful = false;


    if (!ValidateTaskPath(taskPath))
    {
        throw new InvalidTaskPathException();
    }


    int lastIndex = taskPath.LastIndexOf(Constants.TaskPathSeparator);


    string folderPath = taskPath.Substring(0, lastIndex);


    if (string.IsNullOrWhiteSpace(folderPath))
    {
        folderPath = Constants.TaskPathSeparator;
    }


    string taskName = taskPath.Substring(lastIndex &#43; 1);


    try
    {
        this.ConnectTaskSchedulerService();


        ITaskFolder containingFolder = this.taskService.GetFolder(folderPath);


        containingFolder.DeleteTask(taskName, 0);


        ReleaseComObject(containingFolder);


        isSuccessful = true;
    }
    catch (FileNotFoundException exception)
    {
        Logger.LogWarning(Constants.TaskDeleteError, exception);


        throw new InvalidTaskPathException(Constants.InvalidTaskPathError, exception);
    }
    catch (Exception exception)
    {
        Logger.LogError(Constants.TaskDeleteError, exception);


        throw;
    }


    return isSuccessful;
}

</pre>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p class="MsoNormal"></p>
<h1>More Information</h1>
<p class="MsoListParagraph" style="margin-bottom:0in; margin-bottom:.0001pt; text-indent:-.25in; line-height:normal; text-autospace:none">
<span style="font-family:Symbol"><span style="">&bull;<span style="font:7.0pt &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><span style="font-size:9.0pt; font-family:&quot;Courier New&quot;"><span style="">&nbsp;</span></span><span style=""><a href="http://yoursandmyideas.wordpress.com/">http://yoursandmyideas.wordpress.com</a>
</span></p>
<p class="MsoNormal"></p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img alt="" src="http://bit.ly/onecodelogo">
</a></div>

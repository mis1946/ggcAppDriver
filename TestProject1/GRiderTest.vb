﻿Imports System.Data

Imports MySql.Data.MySqlClient

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ggcAppDriver

'''<summary>
'''This is a test class for GRiderTest and is intended
'''to contain all GRiderTest Unit Tests
'''</summary>
<TestClass()> _
Public Class GRiderTest
   Private testContextInstance As TestContext

   '''<summary>
   '''Gets or sets the test context which provides
   '''information about and functionality for the current test run.
   '''</summary>
   Public Property TestContext() As TestContext
      Get
         Return testContextInstance
      End Get
      Set(ByVal value As TestContext)
         testContextInstance = Value
      End Set
   End Property

#Region "Additional test attributes"
   '
   'You can use the following additional attributes as you write your tests:
   '
   'Use ClassInitialize to run code before running the first test in the class
   '<ClassInitialize()>  _
   'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
   'End Sub
   '
   'Use ClassCleanup to run code after all tests in a class have run
   '<ClassCleanup()>  _
   'Public Shared Sub MyClassCleanup()
   'End Sub
   '
   'Use TestInitialize to run code before running each test
   '<TestInitialize()>  _
   'Public Sub MyTestInitialize()
   'End Sub
   '
   'Use TestCleanup to run code after each test has run
   '<TestCleanup()>  _
   'Public Sub MyTestCleanup()
   'End Sub
   '
#End Region


   '''<summary>
   '''A test for LogUser
   '''</summary>
   <TestMethod()> _
   Public Sub LogUserTest()
      Dim fsProdctID As String = "IntegSys" ' TODO: Initialize to an appropriate value
      Dim target As GRider = New GRider(fsProdctID) ' TODO: Initialize to an appropriate value
      Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
      Dim actual As Boolean
      actual = target.LogUser
      Assert.AreEqual(expected, actual)
      Assert.Inconclusive("Verify the correctness of this test method.")
   End Sub

   '''<summary>
   '''A test for LoadEnv
   '''</summary>
   <TestMethod()> _
   Public Sub LoadEnvTest()
      Dim fsProdctID As String = "IntegSys" ' TODO: Initialize to an appropriate value
      Dim target As GRider = New GRider(fsProdctID) ' TODO: Initialize to an appropriate value
      Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
      Dim actual As Boolean
      actual = target.LoadEnv
      Assert.AreEqual(expected, actual)
      Assert.Inconclusive("Verify the correctness of this test method.")
   End Sub

   '''<summary>
   '''A test for ExecuteQuery
   '''</summary>
   <TestMethod()> _
   Public Sub ExecuteQueryTest()
      Dim fsProdctID As String = "IntegSys" ' TODO: Initialize to an appropriate value"
      Dim target As GRider = New GRider(fsProdctID) ' TODO: Initialize to an appropriate value
      Dim fsMySQLCmd As MySqlCommand = Nothing ' TODO: Initialize to an appropriate value
      Dim fsMySQLCmdExpected As MySqlCommand = Nothing ' TODO: Initialize to an appropriate value
      Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
      Dim actual As DataTable
      actual = target.ExecuteQuery(fsMySQLCmd)
      Assert.AreEqual(fsMySQLCmdExpected, fsMySQLCmd)
      Assert.AreEqual(expected, actual)
      Assert.Inconclusive("Verify the correctness of this test method.")
   End Sub

   '''<summary>
   '''A test for ExecuteQuery
   '''</summary>
   <TestMethod()> _
   Public Sub ExecuteQueryTest1()
      Dim fsProdctID As String = String.Empty ' TODO: Initialize to an appropriate value
      Dim target As GRider = New GRider(fsProdctID) ' TODO: Initialize to an appropriate value
      Dim fsSQLCmd As String = String.Empty ' TODO: Initialize to an appropriate value
      Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
      Dim actual As DataTable
      actual = target.ExecuteQuery(fsSQLCmd)
      Assert.AreEqual(expected, actual)
      Assert.Inconclusive("Verify the correctness of this test method.")
   End Sub

   '''<summary>
   '''A test for loadConfig
   '''</summary>
   <TestMethod(), _
    DeploymentItem("ggcAppDriver.dll")> _
   Public Sub loadConfigTest()
      Dim param0 As PrivateObject = Nothing ' TODO: Initialize to an appropriate value
      Dim target As GRider_Accessor = New GRider_Accessor(param0) ' TODO: Initialize to an appropriate value
      Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
      Dim actual As Boolean
      actual = target.loadConfig
      Assert.AreEqual(expected, actual)
      Assert.Inconclusive("Verify the correctness of this test method.")
   End Sub
End Class

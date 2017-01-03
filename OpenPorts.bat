netsh advfirewall firewall add rule name="allowSQLServerBrowser" protocol=UDP dir=in localport=1434 action=allow
netsh advfirewall firewall add rule name="allowSQLServer" protocol=TCP dir=in localport=1433 action=allow

pause
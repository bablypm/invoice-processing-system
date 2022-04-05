#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ABCorp.InvoiceProcessing.Ui/ABCorp.InvoiceProcessing.Ui.csproj", "ABCorp.InvoiceProcessing.Ui/"]
RUN dotnet restore "ABCorp.InvoiceProcessing.Ui/ABCorp.InvoiceProcessing.Ui.csproj"
COPY . .
WORKDIR "/src/ABCorp.InvoiceProcessing.Ui"
RUN dotnet build "ABCorp.InvoiceProcessing.Ui.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ABCorp.InvoiceProcessing.Ui.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ABCorp.InvoiceProcessing.Ui.dll"]
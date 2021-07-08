# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:3.1
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 80/tcp
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh


# # Stage 1: Define base image that will be used for production
# FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
# WORKDIR /app
# EXPOSE 80/tcp

# ENV ASPNETCORE_URLS=http://+:80

# # Stage 2: Build and publish the code
# FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
# WORKDIR /src
# COPY ["BethanysPieShop.csproj", "./"]
# RUN dotnet restore "BethanysPieShop.csproj"
# COPY . .
# WORKDIR "/src/."
# RUN dotnet build "BethanysPieShop.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "BethanysPieShop.csproj" -c Release -o /app/publish

# # Stage 3: Build and publish the code
# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# # ENTRYPOINT ["dotnet", "BethanysPieShop.dll"] # original line, using .sh file
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh
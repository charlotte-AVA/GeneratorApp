terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

provider "azurerm" {
    features {}
}

resource "azurerm_resource_group" "main" {
    # creating a resource group for webb app
    name = "CEM-main-rg"
    location = "uksouth"
}

resource "azurerm_app_service_plan" "sp" {
    # creating a service plan (SP) for web app
    name = "CEM-app-svc"
    kind = "Linux"
    reserved = true //include if using linux 
    sku { 
        # pricing tier
        tier = "Basic"
        size = "B1"
    }
    resource_group_name=azurerm_resource_group.main.name
    location=azurerm_resource_group.main.location
}

resource "azurerm_app_service" "webapp1" {
    # creating web app
    name = "CEM-webapp1"
    resource_group_name=azurerm_resource_group.main.name
    location=azurerm_resource_group.main.location
    app_service_plan_id=azurerm_app_service_plan.sp.id
}

resource "azurerm_app_service" "webapp2" {
    # creating web app
    name = "CEM-webapp2"
    resource_group_name=azurerm_resource_group.main.name
    location=azurerm_resource_group.main.location
    app_service_plan_id=azurerm_app_service_plan.sp.id
}

resource "azurerm_app_service" "webapp3" {
    # creating web app
    name = "CEM-webapp3"
    resource_group_name=azurerm_resource_group.main.name
    location=azurerm_resource_group.main.location
    app_service_plan_id=azurerm_app_service_plan.sp.id
}

resource "azurerm_app_service" "webapp4" {
    # creating web app
    name = "CEM-webapp4"
    resource_group_name=azurerm_resource_group.main.name
    location=azurerm_resource_group.main.location
    app_service_plan_id=azurerm_app_service_plan.sp.id
}
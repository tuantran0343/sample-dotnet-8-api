import os
import sys

def connect_database():
    # Đọc từ biến môi trường thay vì sys.argv
    conn_string = os.getenv("DB_CONNECTION_STRING")
    app_host = os.getenv("APP_URL_INTERNAL")

    print(f"App host data: {app_host}")

    if not conn_string:
        print("❌ Error: DB_CONNECTION_STRING is not set!")
        sys.exit(1)

    print("--- Python Database Manager ---")
    
    if "staging" in conn_string.lower():
        print("🛠️  Detected: STAGING Environment")
        # Giả lập logic lấy host
        print(f"🔗 Connecting to STAGING Server:")
        
    elif "production" in conn_string.lower():
        print("🚀 Detected: PRODUCTION Environment")
        print("⚠️  Warning: Executing on Live Database!")
        print(f"🔗 Connecting to PRODUCTION Server:")
    
    print("✅ Connection established successfully!")
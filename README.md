DoS Attack Detection using Machine Learning
Project Overview
This project implements a Machine Learning-based system to detect Denial-of-Service (DoS) attacks using the CIC-IDS2017 dataset. The dataset contains labeled network traffic features, including TCP flows, packet counts, and flag statistics.
The project focuses on binary classification: distinguishing normal traffic from DoS attacks.
Features Used
Key TCP flow features extracted from the dataset include:
Flow Duration
Total Fwd Packets
Total Backward Packets
Total Length of Fwd Packets
Total Length of Bwd Packets
SYN Flag Count
ACK Flag Count
RST Flag Count
These features are used as independent variables, while the Label column is the dependent variable.
Machine Learning Models
The following ML models are implemented for DoS detection:
Random Forest: Baseline model for feature importance and classification.
Optional extensions: Gradient Boosting (XGBoost/LightGBM), Neural Networks for more advanced experiments.
